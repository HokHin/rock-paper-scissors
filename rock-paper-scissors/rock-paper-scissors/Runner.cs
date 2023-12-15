using rock_paper_scissors.Enums;
using rock_paper_scissors.Models;
using rock_paper_scissors.Services;

namespace rock_paper_scissors;

public class Runner : IRunner
{
    public Task RunAsync()
    {
        GameDecision gameDecision = new();

        var gameResult = new GameResult();

        gameDecision.GetGameDecision(Choices.Rock, Choices.Scissors, gameResult);

        Console.WriteLine(gameResult.WinCount);
        Console.WriteLine(gameResult.DrawCount);
        Console.WriteLine(gameResult.LoseCount);
        
        return Task.CompletedTask;
    }
}