using Maplink.Webservices.Places.Client.Entities;

namespace Maplink.Webservices.Places.Client.Builders
{
    public interface IUriBuilder
    {
        string For(Request request);
    }
}