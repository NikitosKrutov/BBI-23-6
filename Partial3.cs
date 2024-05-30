namespace Classes
{
    public partial class Festival
    {
        public static void Sort(FestivalCalendar array)
        {
            for (int i = 1; i < array.Festivals.Count; i++)
            {
                Festival k = array.Festivals[i];
                int j = i - 1;

                while (j >= 0 && array.Festivals[j].ticketPrice < k.ticketPrice)
                {
                    array.Festivals[j + 1] = array.Festivals[j];
                    j--;
                }
		    array.Festivals[j + 1] = k;
            }
        }
    }
}

