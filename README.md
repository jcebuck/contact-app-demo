# Contact Directory Application
Contact Directory Application built using C#, ASP.NET MVC & AngularJS, with additionality functionality of Google Maps JavaScript API.

## Google Maps API Key
For security reasons, API keys have been ignored in Git.
In order to get the application working with the Google Maps, you will need to add your own API key after cloning the repository.

In order to do this, create a file named `appSettings.config` in the `ContactApplication` folder, using the template:
```
<?xml version="1.0" encoding="utf-8" ?>
<appSettings>
  <add key="gMapsApiKey" value="" />
</appSettings>
```
and replace the `gMapsApiKey` value with your API key.
