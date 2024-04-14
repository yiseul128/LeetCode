Solution s = new Solution();
Console.WriteLine(s.PeopleAwareOfSecret(6, 1, 2));


public class Solution
{
    private static long _mod = 1000000007;
    public int PeopleAwareOfSecret(int n, int delay, int forget)
    {
        long[] dp = new long[n + 1];
        long secretSharer = 0;
        long answer = 0;

        dp[1] = 1;

        for (int i = 2; i <= n; i++)
        {
            long nOfNewActive = dp[Math.Max(i - delay, 0)];
            long nOfForget = dp[Math.Max(i - forget, 0)];
            secretSharer = (secretSharer + nOfNewActive - nOfForget + _mod) % _mod;
            dp[i] = secretSharer;
        }


        for (int i = n - forget + 1; i <= n; i++)
        {
            answer = (answer + dp[i]) % _mod;
        }
        return Convert.ToInt32(answer);

        // Queue<ulong> forgetQueue = new Queue<ulong>();
        // forgetQueue.Enqueue(1);
        // Queue<ulong> dormantQueue = new Queue<ulong>();
        // dormantQueue.Enqueue(1);

        // ulong answer = CirculateSecret(n, delay, forget, 1, 1, forgetQueue, dormantQueue, 1);
        // Console.WriteLine(answer);
        // return Convert.ToInt32(answer%_mod);
    }

    // public ulong CirculateSecret(int n, int delay, int forget, int daysPassed, ulong secretSharer, Queue<ulong> forgetQueue, Queue<ulong> dormantQueue, ulong dormantactive){
    //     // forget
    //     if (daysPassed > forget)
    //     {
    //         if (daysPassed == forget + 1 || daysPassed > forget + delay)
    //         {
    //             // ulong prevactive = active;
    //             ulong forgot = forgetQueue.Dequeue();
    //             active = (active-forgot);
    //         }            
    //     }

    //     // share
    //     if(daysPassed>delay){
    //         if(daysPassed==delay+1 || daysPassed>delay*2){
    //             ulong newActive = dormantQueue.Dequeue();
    //             dormantactive=(dormantactive-newActive);    
    //         }

    //         ulong active = (active - dormantactive);
    //         active = (active+active);
    //         dormantactive = (dormantactive+active);
    //         dormantQueue.Enqueue(active);
    //         forgetQueue.Enqueue(active);
    //     }

    //     if(n==daysPassed){
    //         return active;
    //     }

    //     //recur
    //     return CirculateSecret(n, delay, forget, daysPassed+1, active, forgetQueue, dormantQueue, dormantactive);
    // }
}