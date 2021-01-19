using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace SistemaBiblioteca
{
    public class BackupDrive
    {
        static string[] Scopes = { DriveService.Scope.DriveReadonly };
        public BackupDrive() { }
        private Google.Apis.Drive.v3.DriveService ConectarGoogle()
        {
            string clientId, clientSecret;

            try
            {
                JObject o1 = JObject.Parse(File.ReadAllText(System.IO.Directory.GetCurrentDirectory() + @"\credentials.json"));

                using (StreamReader file = File.OpenText(System.IO.Directory.GetCurrentDirectory() + @"\credentials.json"))
                using (JsonTextReader reader = new JsonTextReader(file))
                {
                    JObject o2 = (JObject)JToken.ReadFrom(reader);

                    clientId = o2["installed"]["client_id"].ToString();
                    clientSecret = o2["installed"]["client_secret"].ToString();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            string[] scopes = new string[] { DriveService.Scope.Drive,
                               DriveService.Scope.DriveFile,};

            var credential = GoogleWebAuthorizationBroker.AuthorizeAsync(new ClientSecrets
            {
                ClientId = clientId,
                ClientSecret = clientSecret
            }, scopes,
            Environment.UserName, CancellationToken.None, new FileDataStore("MyAppsToken")).Result;

            DriveService service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "sistema-biblioteca",

            });
            service.HttpClient.Timeout = TimeSpan.FromMinutes(100);

            return service;
        }
        public void SalvarArquivo(string arquivo, string pasta = "")
        {
            Google.Apis.Drive.v3.DriveService service = ConectarGoogle();
            uploadFile(service, arquivo, pasta);
        }
        private void uploadFile(Google.Apis.Drive.v3.DriveService _service, string _uploadFile, string _parent, string _descrp = "Backup dos dados da biblioteca.")
        {
            if (System.IO.File.Exists(_uploadFile))
            {
                Google.Apis.Drive.v3.Data.File body = new Google.Apis.Drive.v3.Data.File();
                body.Name = System.IO.Path.GetFileName(_uploadFile);
                body.Description = _descrp;
                body.MimeType = "application/zip";
                if (_parent != "") { body.Parents = new List<string> { _parent }; }
                byte[] byteArray = System.IO.File.ReadAllBytes(_uploadFile);
                System.IO.MemoryStream stream = new System.IO.MemoryStream(byteArray);
                try
                {
                    Google.Apis.Drive.v3.FilesResource.CreateMediaUpload request = _service.Files.Create(body, stream, "application/zip");
                    request.SupportsTeamDrives = true;
                    request.Upload();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
        public IList<Google.Apis.Drive.v3.Data.File> GetPastas()
        {
            var service = ConectarGoogle();
            FilesResource.ListRequest listRequest = service.Files.List();
            listRequest.PageSize = 10;
            listRequest.Fields = "nextPageToken,files(id, name)";
            listRequest.Q = "mimeType='application/vnd.google-apps.folder'";

            IList<Google.Apis.Drive.v3.Data.File> files = listRequest.Execute().Files;

            return files;
        }
        public IList<Google.Apis.Drive.v3.Data.File> GetArquivos()
        {
            var service = ConectarGoogle();
            FilesResource.ListRequest listRequest = service.Files.List();
            listRequest.PageSize = 10;
            listRequest.Fields = "nextPageToken,files(id, name)";
            listRequest.Q = "mimeType='application/zip'";

            IList<Google.Apis.Drive.v3.Data.File> files = listRequest.Execute().Files;

            return files;
        }
        public void BaixarArquivo(string id, string caminho)
        {
            Google.Apis.Drive.v3.DriveService service = ConectarGoogle();

            var request = service.Files.Get(id);
            var stream = new System.IO.MemoryStream();

            request.MediaDownloader.ProgressChanged += (Google.Apis.Download.IDownloadProgress progress) =>
            {
                switch (progress.Status)
                {
                    case Google.Apis.Download.DownloadStatus.Downloading:
                        {
                            break;
                        }
                    case Google.Apis.Download.DownloadStatus.Completed:
                        {
                            SaveStream(stream, caminho);
                            break;
                        }
                    case Google.Apis.Download.DownloadStatus.Failed:
                        {
                            break;
                        }
                }
            };
            request.Download(stream);
        }
        private static void SaveStream(System.IO.MemoryStream stream, string saveTo)
        {
            using (System.IO.FileStream file = new System.IO.FileStream(saveTo, System.IO.FileMode.Create, System.IO.FileAccess.Write))
            {
                stream.WriteTo(file);
            }
        }
    }
}
