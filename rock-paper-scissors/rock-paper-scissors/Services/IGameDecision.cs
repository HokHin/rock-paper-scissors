using rock_paper_scissors.Enums;
using rock_paper_scissors.Models;

namespace rock_paper_scissors.Services;

public interface IGameDecision
{
    public int GetGameDecision(Choices ourChoice, Choices competitorChoice, GameResult gameResult);
}