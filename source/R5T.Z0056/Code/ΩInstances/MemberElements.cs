using System;


namespace R5T.Z0056
{
    public class MemberElements : IMemberElements
    {
        #region Infrastructure

        public static IMemberElements Instance { get; } = new MemberElements();


        private MemberElements()
        {
        }

        #endregion
    }
}
