using Telegram.Bot.Types;

namespace WoTStatsBoostBot.Interfaces
{
    public interface ICommandExecutor
    {
        Task Execute(Update update);
    }
}
