using Telegram.Bot.Types;

namespace WoTStatsBoostBot.Commands
{
    public abstract class BaseCommand
    {
        public abstract string Name { get; }
        public abstract Task ExecuteAsync(Update update);
    }
}
