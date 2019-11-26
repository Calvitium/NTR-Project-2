using System;


namespace NTR02
{
    public static class NotebookControl
    {
        public static string filterCat;
        public static DateTime fromDate;
        public static DateTime toDate;
    
        static NotebookControl()
        {
            SetDefaults();
        }
        public static void SetDefaults()
        {
            fromDate = DateTime.Now.Date;
            toDate = DateTime.Now.AddYears(5);
            filterCat = null;
        }
    }
    
}