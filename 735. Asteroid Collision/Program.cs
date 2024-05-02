public class Solution
{
    public int[] AsteroidCollision(int[] asteroids)
    {
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < asteroids.Length; i++)
        {
            int currAsteroid = asteroids[i];

            bool bothExploding = false;
            while (stack.Count > 0 && stack.Peek() > 0 && currAsteroid < 0 && !bothExploding)
            {
                int poppedAsteroid = stack.Pop();
                int absPoppedAsteroid = Math.Abs(poppedAsteroid);
                int absCurrAsteroid = Math.Abs(currAsteroid);
                if (absPoppedAsteroid == absCurrAsteroid)
                {
                    bothExploding = true;
                }
                else
                {
                    currAsteroid = absCurrAsteroid > absPoppedAsteroid ? currAsteroid : poppedAsteroid;
                }
            }

            if (!bothExploding)
            {
                stack.Push(currAsteroid);
            }
        }

        int[] answer = new int[stack.Count];
        for (int i = answer.Length - 1; i >= 0; i--)
        {
            answer[i] = stack.Pop();
        }
        return answer;
    }
}