namespace RefactorSample.MovingFeaturesBetweenObjects.IntroduceLocalExtension;

public class After
{
    public class DateWrapper
    {
        private readonly Date _originalDate;

        public DateWrapper(Date originalDate)
        {
            _originalDate = originalDate;
        }

        public bool IsWeekend()
        {
            return _originalDate.Day % 7 == 0 || _originalDate.Day % 7 == 6;
        }

        public int DaysUntilNewYear()
        {
            return (12 - _originalDate.Month) * 30 + (30 - _originalDate.Day);
        }

        // 委託原始方法
        public override string ToString() => _originalDate.ToString();
    }
}