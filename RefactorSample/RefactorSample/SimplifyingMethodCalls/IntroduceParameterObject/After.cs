namespace RefactorSample.SimplifyingMethodCalls.IntroduceParameterObject;

public class After
{
    public class ReservationDetails
    {
        public string CustomerName { get; set; }
        
        public string PhoneNumber { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int RoomNumber { get; set; }
        public bool NeedsExtraBed { get; set; }
    }

    public class ReservationSystem
    {
        public void MakeReservation(ReservationDetails details)
        {
            // 預訂邏輯
            Console.WriteLine($"預訂成功：{details.CustomerName}，房間號{details.RoomNumber}，" +
                              $"入住日期{details.CheckInDate:d}，退房日期{details.CheckOutDate:d}");
            if (details.NeedsExtraBed)
            {
                Console.WriteLine("已安排加床");
            }
        }
    } 
}