using System;

using R5T.T0131;
using R5T.T0212;


namespace R5T.Z0056
{
    [ValuesMarker]
    public partial interface IMemberElements : IValuesMarker
    {
        /// <inheritdoc cref="Z0055.IMemberElementXmlTexts.Self_Referential"/>
        public IMemberElement Self_Referential => Instances.MemberElementOperator.Parse(
            Instances.MemberElementXmlTexts.Self_Referential);
    }
}
