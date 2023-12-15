using rock_paper_scissors.Enums;
using rock_paper_scissors.Models;

namespace rock_paper_scissors.Services;

public class GameDecision : IGameDecision
{
    public int GetGameDecision(Choices ourChoice, Choices competitorChoice, GameResult gameResult)
    {
        if ((ourChoice == Choices.Paper) & (competitorChoice == Choices.Rock)) return gameResult.WinCount += 1;

        if ((ourChoice == Choices.Paper) & (competitorChoice == Choices.Scissors)) return gameResult.LoseCount += 1;

        if ((ourChoice == Choices.Rock) & (competitorChoice == Choices.Paper)) return gameResult.LoseCount += 1;

        if ((ourChoice == Choices.Rock) & (competitorChoice == Choices.Scissors)) return gameResult.WinCount += 1;

        if ((ourChoice == Choices.Scissors) & (competitorChoice == Choices.Paper)) return gameResult.WinCount += 1;

        if ((ourChoice == Choices.Scissors) & (competitorChoice == Choices.Rock)) return gameResult.LoseCount += 1;

        return gameResult.DrawCount += 1;
    }
}