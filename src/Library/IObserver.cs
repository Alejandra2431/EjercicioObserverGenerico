namespace Observer
{
    public interface IObserver<Temp>
    {
        void Update(Temp value);
    }
}