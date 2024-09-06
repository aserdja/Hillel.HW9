namespace AsyncDownloaderApp
{
	public class DataDownloader
	{
		public async Task DownloadDataAsync(string url, string filePath)
		{
			var httpClient = new HttpClient();
			var result = await httpClient.GetAsync(url);

			using (StreamWriter sw = new StreamWriter(filePath))
			{
                await sw.WriteAsync(result.ToString());
			}
		}
	}
}
