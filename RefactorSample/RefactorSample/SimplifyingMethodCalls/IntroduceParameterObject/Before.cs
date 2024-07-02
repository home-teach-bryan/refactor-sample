namespace RefactorSample.SimplifyingMethodCalls.IntroduceParameterObject;

public class Before
{
    public class ReservationSystem
    {
        public void MakeReservation(string customerName, string phoneNumber, DateTime checkInDate, 
            DateTime checkOutDate, int roomNumber, bool needsExtraBed)
        {
            // 預訂邏輯
            Console.WriteLine($"預訂成功：{customerName}，房間號{roomNumber}，" +
                              $"入住日期{checkInDate:d}，退房日期{checkOutDate:d}");
            if (needsExtraBed)
            {
                Console.WriteLine("已安排加床");
            }
        }
    }
}