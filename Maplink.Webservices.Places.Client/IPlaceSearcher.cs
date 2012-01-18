using Maplink.Webservices.Places.Client.Arguments;
using Maplink.Webservices.Places.Client.Entities;

namespace Maplink.Webservices.Places.Client
{
    public interface IPlaceSearcher
    {
        PlaceSearchResult ByRadius(PlaceSearchRequest placeSearchRequest);
        PlaceSearchResult ByTerm(PlaceSearchRequest placeSearchRequest);
        PlaceSearchResult ByCategory(PlaceSearchRequest placeSearchRequest);
        PlaceSearchResult ByUri(PaginationRequest paginationRequest);
    }
}