using System;

using R5T.T0131;
using R5T.T0212;


namespace R5T.Z0056.Raw
{
    [ValuesMarker]
    public partial interface IMemberElements : IValuesMarker
    {
        /// <inheritdoc cref="Z0055.Raw.IMemberElementXmlTexts.Pathological_AX"/>
        public IMemberElement Pathological_AX => Instances.MemberElementOperator.Parse(
            Instances.MemberElementXmlTexts_Raw.Pathological_AX);

        /// <inheritdoc cref="Z0055.Raw.IMemberElementXmlTexts.Pathological_A"/>
        public IMemberElement Pathological_A => Instances.MemberElementOperator.Parse(
            Instances.MemberElementXmlTexts_Raw.Pathological_A);

        /// <inheritdoc cref="Z0055.Raw.IMemberElementXmlTexts.R5T_S0082_Program_A"/>
        public IMemberElement R5T_S0082_Program_A => Instances.MemberElementOperator.Parse(
            Instances.MemberElementXmlTexts_Raw.R5T_S0082_Program_A);

        /// <inheritdoc cref="Z0055.Raw.IMemberElementXmlTexts.R5T_S0082_Program_B"/>
        public IMemberElement R5T_S0082_Program_B => Instances.MemberElementOperator.Parse(
            Instances.MemberElementXmlTexts_Raw.R5T_S0082_Program_B);

        /// <inheritdoc cref="Z0055.Raw.IMemberElementXmlTexts.R5T_S0082_Program_C"/>
        public IMemberElement R5T_S0082_Program_C => Instances.MemberElementOperator.Parse(
            Instances.MemberElementXmlTexts_Raw.R5T_S0082_Program_C);

        /// <inheritdoc cref="Z0055.Raw.IMemberElementXmlTexts.R5T_Y0000_Glossary_ForIndex_Exclusive"/>
        public IMemberElement R5T_Y0000_Glossary_ForIndex_Exclusive => Instances.MemberElementOperator.Parse(
            Instances.MemberElementXmlTexts_Raw.R5T_Y0000_Glossary_ForIndex_Exclusive);

        /// <inheritdoc cref="Z0055.Raw.IMemberElementXmlTexts.R5T_Y0000_Glossary_ForIndex_ExclusiveInclusiveRelationship"/>
        public IMemberElement R5T_Y0000_Glossary_ForIndex_ExclusiveInclusiveRelationship => Instances.MemberElementOperator.Parse(
            Instances.MemberElementXmlTexts_Raw.R5T_Y0000_Glossary_ForIndex_ExclusiveInclusiveRelationship);

        /// <inheritdoc cref="Z0055.Raw.IMemberElementXmlTexts.R5T_Y0000_Glossary_ForIndex_Inclusive"/>
        public IMemberElement R5T_Y0000_Glossary_ForIndex_Inclusive => Instances.MemberElementOperator.Parse(
            Instances.MemberElementXmlTexts_Raw.R5T_Y0000_Glossary_ForIndex_Inclusive);
    }
}
