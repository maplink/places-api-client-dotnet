using Maplink.Webservices.Places.Client.Arguments;
using Maplink.Webservices.Places.Client.Entities;

namespace Maplink.Webservices.Places.Client.Builders
{
    public class PlaceSearchRequestBuilder : IPlaceSearchRequestBuilder
    {
        private PlaceSearchRequest _request;

        public PlaceSearchRequestBuilder()
        {
            _request = CreateADefaultRequest();            
        }

        public IPlaceSearchRequestBuilder ForLicense(string login, string key)
        {
            _request.LicenseInfo.Login = login;
            _request.LicenseInfo.Key = key;

            return this;
        }

        public IPlaceSearchRequestBuilder BasedOnRadius(double radius, double latitude, double longitude)
        {
            _request.Radius = radius;
            _request.Latitude = latitude;
            _request.Longitude = longitude;

            return this;
        }

        public IPlaceSearchRequestBuilder BasedOnTerm(string term)
        {
            return FilteredByTerm(term);
        }

        public IPlaceSearchRequestBuilder FilteredByTerm(string term)
        {
            _request.Term = term;

            return this;
        }

        public IPlaceSearchRequestBuilder FilteredByCity(string city)
        {
            _request.City = city;

            return this;
        }

        public IPlaceSearchRequestBuilder FilteredByState(string state)
        {
            _request.State = state;

            return this;
        }

        public IPlaceSearchRequestBuilder BasedOnCategory(int category)
        {
            return FilteredByCategory(category);
        }

        public IPlaceSearchRequestBuilder FilteredByCategory(int categoryId)
        {
            _request.CategoryId = categoryId;

            return this;
        }

        public IPlaceSearchRequestBuilder StartingAtIndex(int startIndex)
        {
            _request.StartIndex = startIndex;

            return this;
        }

        public PlaceSearchRequest Build()
        {
            var request = _request;

            _request = CreateADefaultRequest();

            return request;
        }

        private static PlaceSearchRequest CreateADefaultRequest()
        {
            return new PlaceSearchRequest
            {
                LicenseInfo = new LicenseInfo()
            };
        }
    }
}