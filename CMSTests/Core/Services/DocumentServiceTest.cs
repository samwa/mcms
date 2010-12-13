


namespace CMSTests.Core.Services
{
	using System;
	
	using NUnit.Framework;
	
	using Moq;

	using CMSCore.Entities;
	using CMSCore.Services;
	
	[TestFixture]
	public class DocumentServiceTest
	{
		private Mock<IDocument> _mockDocument;
		private Mock<IDocumentService> _mockDocumentService;
		
		[SetUp]
		public void SetupFixture()
		{
			_mockDocument = new Mock<IDocument>();
		}
		
		[TearDown]
		public void TeardownFixture()
		{
			
		}		
		
		[Test]
		public void Add_Document_Test()
		{
			//_mockDocument.Setup(m => m.
		}
	}
}

