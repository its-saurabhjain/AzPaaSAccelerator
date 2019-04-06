using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace StorageService
{
    public interface IStorageService
    {
        Task<string> UploadAsync(string path, IFormFile content, string nameWithoutExtension = null);
    }
}
