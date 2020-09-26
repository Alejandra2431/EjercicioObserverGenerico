namespace Observer
{
    public interface IObservable<Temp>
    {
        void Subscribe(IObserver<Temp> observer);

        void Unsubscribe(IObserver<Temp> observer);
    }
}