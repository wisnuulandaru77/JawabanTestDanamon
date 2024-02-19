namespace MainServiceDanamon.Models.Dtos;

public class MessageBrokerDTO<T> : BaseMessageBrokerDTO
{
    public T data { get; set; }
}
