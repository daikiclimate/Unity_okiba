using System;
using Hidakkathon.Application.Practice;

using Environment = Hidakkathon.Application.Practice.Environment;

public class EnemyBrain : PlayerBrain
{
    public override HandType Think(HandType handType)
    {
        var random = new Random(DateTime.Now.GetHashCode());
        switch (random.Next(0, 3))
        {
            case 0:
                return HandType.Scissors;
            case 1:
                return HandType.Paper;
            case 2:
                return HandType.Rock;
        }

        return HandType.Scissors;
    }
}
