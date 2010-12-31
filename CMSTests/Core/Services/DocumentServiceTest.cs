


	using CMSWeb.Models;

namespace CMSTests.Core.Services
{
	using System;
	
	using NUnit.Framework;
	
	using Moq;
	
	[TestFixture]
	public class DocumentServiceTest
	{
		private Mock<Document> _mockDocument;
		private Mock<IDocumentRepository> _mockDocumentRepository;
		
		[SetUp]
		public void SetupFixture()
		{			
			_mockDocument = new Mock<Document>();
		}
		
		[TearDown]
		public void TeardownFixture()
		{
			
		}		
		
		[Test]
		public void Add_Document_Test()
		{
			//_mockDocumentService.Setup(m => m.AddDocument(
		}
	}
}

