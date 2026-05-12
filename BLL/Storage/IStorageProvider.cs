public interface IStorageProvider
{
    Task<string> UploadAsync(Stream data, string path, CancellationToken ct = default);
    Task<Stream?> DownloadAsync(string path, CancellationToken ct = default);
}