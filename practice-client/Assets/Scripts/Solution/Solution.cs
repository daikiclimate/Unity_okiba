using Hidakkathon.Application.Practice;

namespace Task1
{
    public class Solution : PlayerBrain
    {
        public override HandType Think(HandType handType)
        {
            if (handType == HandType.Scissors)
            {
                return HandType.Rock;
            }
            else if (handType == HandType.Rock)
            {
                return HandType.Paper;
            }
            else
            {
                return HandType.Scissors;
            
            }

            // TODO: ここを実装します
            //return HandType.Scissors;
        }
    }
}
