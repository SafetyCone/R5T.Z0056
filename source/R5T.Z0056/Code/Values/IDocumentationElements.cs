using System;

using R5T.T0131;
using R5T.T0212;


namespace R5T.Z0056
{
    [ValuesMarker]
    public partial interface IDocumentationElements : IValuesMarker
    {
        public IDocumentationElement R5T_T0211 => Instances.DocumentationElementOperator.Get_DocumentationElement(
            Instances.DocumentationFileXmlTexts.R5T_T0211);
    }
}
