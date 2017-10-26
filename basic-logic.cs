<script Language="c#" runat="server">
  void Page_Load()
  {
   DateTime date = DateTime.Now;
   dateToday.Text = " " + date.ToString("d");
   DayOfWeek day = DateTime.Now.DayOfWeek;
   dayToday.Text = " " + day.ToString();

   if ((dayToday == DayOfWeek.Saturday) && (dayToday == DayOfWeek.Sunday))
    {
    Console.WriteLine("This is a weekend");
    }

 }
</script>
