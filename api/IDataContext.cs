using firstApi;

namespace api
{
    public interface IDataContext
    {
        List<Event> EventList { get; set; }
    }
}
