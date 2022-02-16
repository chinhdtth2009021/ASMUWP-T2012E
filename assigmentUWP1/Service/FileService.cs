using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace assigmentUWP1.Service
{
    public class FileService
    {

        private static string CloudName = "xuanhung2401";
        private static string CloudApiKey = "882796476526336";
        private static string CloudApiSecret = "gOOT_72AMyn9TQz1Hd4MxyGRjxY";

        static CloudinaryDotNet.Account account;
        static CloudinaryDotNet.Cloudinary cloudinary;
        public FileService()
        {
            if (account == null)
            {
                account = new CloudinaryDotNet.Account
                {
                    Cloud = CloudName,
                    ApiKey = CloudApiKey,
                    ApiSecret = CloudApiSecret
                };
            }
            if (cloudinary == null)
            {
                cloudinary = new CloudinaryDotNet.Cloudinary(account);
                cloudinary.Api.Secure = true;
            }
        }
        public async Task<string> UploadFile(StorageFile file)
        {
            if (file != null)
            {
                CloudinaryDotNet.Actions.RawUploadParams imageUploadParams = new CloudinaryDotNet.Actions.RawUploadParams
                {
                    File = new CloudinaryDotNet.FileDescription(file.Name, await file.OpenStreamForReadAsync())
                };
                //Thực hiện upload lấy thông tin về.
                CloudinaryDotNet.Actions.RawUploadResult result = await cloudinary.UploadAsync(imageUploadParams);
                return result.SecureUrl.OriginalString;
            }
            return null;
        }
    }
}
