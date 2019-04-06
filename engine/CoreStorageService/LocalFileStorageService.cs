using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace StorageService
{
    public class LocalFileStorageService : IStorageService
    {
        private readonly IHostingEnvironment _env;

        public LocalFileStorageService(IHostingEnvironment env)
        {
            _env = env;
        }

        public async Task<string> UploadAsync(string path, IFormFile content, string nameWithoutExtension = null)
        {
            if (content != null && content.Length > 0)
            {
                string extension = Path.GetExtension(content.FileName);

                // Never trust user's provided file name
                string fileName = $"{ nameWithoutExtension ?? Guid.NewGuid().ToString() }{ extension }";

                // Combine the path with web root and my folder of choice, 
                // "uploads" 
                path = Path.Combine(_env.WebRootPath, "uploads", path).ToLower();

                // If the path doesn't exist, create it.
                // In your case, you might not need it if you're going 
                // to make sure your `keys.json` file is always there.
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                // Combine the path with the file name
                string fullFileLocation = Path.Combine(path, fileName).ToLower();

                // If your case, you might just need to open your 
                // `keys.json` and append text on it.
                // Note that there is FileMode.Append too you might want to
                // take a look.
                using (var fileStream = new FileStream(fullFileLocation, FileMode.Create))
                {
                    await content.CopyToAsync(fileStream);
                }

                // I only want to get its relative path
                return fullFileLocation.Replace(_env.WebRootPath,
                    String.Empty, StringComparison.OrdinalIgnoreCase);
            }

            return String.Empty;
        }

        
    }
}
