using AsyncDownloaderApp;

var dataDownloader = new DataDownloader();
await dataDownloader.DownloadDataAsync("https://youtube.com", "C:\\Users\\andre\\OneDrive\\Desktop\\text.txt");