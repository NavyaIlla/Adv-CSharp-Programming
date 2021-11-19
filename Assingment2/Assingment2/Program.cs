using System;
using System.Threading.Tasks;
namespace Assignment2
{
	class Program
	{
		static void Main(string[] args)
		{
			Document doc = new Document();

			SignDocumnet(doc);

		}
		static async void SignDocumnet(Document documentContent)
		{
			String content1 = await SantizeDocumentContentAsync(documentContent);
			String content2 = await HashSantizedDocumentContentAsync(content1);
			String content3 = await EncryptDigestUsingPrivateKeyAsync(content2);
		}
		private static Task<string> SantizeDocumentContentAsync(Document documentContent)
		{
			return Task.Run<string>(() =>
			{
				return SantizeDocumentContent(documentContent);
			});
		}
		static string SantizeDocumentContent(Document documentContent)
		{
			Task.Delay(2000).Wait();
			return documentContent.text + " Santized ";
		}



		private static Task<string> HashSantizedDocumentContentAsync(string santizedDocumentContent)
		{
			return Task.Run<string>(() =>
			{
				return HashSantizedDocumentContent(santizedDocumentContent);
			});
		}
		static string HashSantizedDocumentContent(string santizedDocumentContent)
		{
			Task.Delay(2000).Wait();
			return santizedDocumentContent + " Hashed ";
		}


		private static Task<string> EncryptDigestUsingPrivateKeyAsync(string digest)
		{
			return Task.Run<string>(() =>
			{
				return EncryptDigestUsingPrivateKey(digest);
			});
		}
		static string EncryptDigestUsingPrivateKey(string digest)
		{
			Task.Delay(2000).Wait();
			return digest + " Encrypted ";
		}

	}
}
