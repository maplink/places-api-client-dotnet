using Maplink.Webservices.Places.Client.Arguments;

namespace Maplink.Webservices.Places.Client.Builders
{
    public interface IPlaceSearchRequestBuilder
    {
        IPlaceSearchRequestBuilder ForLicense(string login, string key);
        IPlaceSearchRequestBuilder BasedOnRadius(double radius, double latitude, double longitude);
        IPlaceSearchRequestBuilder BasedOnTerm(string term);
        IPlaceSearchRequestBuilder BasedOnCity(string city);
        IPlaceSearchRequestBuilder BasedOnState(string state);
        IPlaceSearchRequestBuilder FilteredByTerm(string term);
        IPlaceSearchRequestBuilder FilteredByCity(string city);
        IPlaceSearchRequestBuilder FilteredByState(string state);
        IPlaceSearchRequestBuilder FilteredByCategory(int categoryId);
        IPlaceSearchRequestBuilder StartingAtIndex(int startIndex);
        PlaceSearchRequest Build();
    }
}