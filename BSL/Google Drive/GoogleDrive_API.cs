using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.Util.Store;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BSL.Google_Drive
{
    public class GoogleDrive_API
    {
        private static string[] Scopes = { DriveService.Scope.Drive };
        private static string ApplicationName = "Gestor trailers - Peliculas";

        private readonly DriveService _driveService;

        public GoogleDrive_API()
        {
            string credentialsPath = "C:\\Users\\gvian\\OneDrive\\Documents\\Maxi\\MATERIAS CARRERA U.A.I\\6to CUATRIMESTRE\\LUG\\INTEGRADOR";

            UserCredential credential;

            using (var stream = new FileStream(Path.Combine(credentialsPath, "mis-credenciales.json"), FileMode.Open, FileAccess.Read))
            {
                string credPath = "C:\\Users\\gvian\\OneDrive\\Documents\\Maxi\\MATERIAS CARRERA U.A.I\\6to CUATRIMESTRE\\LUG\\INTEGRADOR";

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.FromStream(stream).Secrets,
                    Scopes,
                    "usuario",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
            }

            _driveService = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
        }


        public string SubirVideo(string rutaDelVideo)
        {
            string mimeType = "video/mp4"; 

            var fileMetadata = new Google.Apis.Drive.v3.Data.File()
            {
                Name = Path.GetFileName(rutaDelVideo),
                Parents = new[] { "1swIcv-VuWksX75UsiFIlcQI-oxYWdqF1" },
            };

            FilesResource.CreateMediaUpload request;

            using (var stream = new FileStream(rutaDelVideo, FileMode.Open))
            {
                request = _driveService.Files.Create(fileMetadata, stream, mimeType);
                request.Upload();
            }

            var file = request.ResponseBody;

            var permission = new Permission
            {
                Type = "anyone",
                Role = "reader",
            };

            _driveService.Permissions.Create(permission, file.Id).Execute();

            return $"https://drive.google.com/uc?id={file.Id}";
        }

    }
}
