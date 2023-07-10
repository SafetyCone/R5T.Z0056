using System;


namespace R5T.Z0056
{
    public class DocumentationElements : IDocumentationElements
    {
        #region Infrastructure

        public static IDocumentationElements Instance { get; } = new DocumentationElements();


        private DocumentationElements()
        {
        }

        #endregion
    }
}
