using System;
using System.Threading.Tasks;

namespace InfyShop.MessageBus
{
    public interface IMessageBus
    {
        Task PublishMessage(BaseMessage message, string topicName);
    }
}
