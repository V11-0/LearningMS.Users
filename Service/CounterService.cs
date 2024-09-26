namespace LearningMS.Users.Service;

public interface ICounterService {
    public int Increment();
}

public class CounterService : ICounterService
{
    private int counter = 0;

    public int Increment()
    {
        counter++;
        return counter;
    }
}