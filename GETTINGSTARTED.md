# Integrate.Interview.Frontend

## Prerequisites
You must have the following dependencies installed:
* [.NET Core](https://dotnet.microsoft.com/download)
* [NodeJS](https://nodejs.org/en/)

## Backend API
### Running the API
From the root directory of this repo, run the following in a command line.

```
cd ./Backend/Integrate.Interview.Frontend/Integrate.Interview.Frontend/
dotnet run
```

_Note that if you're using Windows, some command line tools may require back slashes (`\`) in your directory paths._

### Viewing the API Documentation
The API includes Swagger documentation so you can easily call it from your UI. To view the documentation, navigate to `https://localhost:5001/swagger`.

## React UI
### Running the React App
From the root directory of this repo, run the following in a command line:

```
cd ./Frontend/integrate-interview-frontend
npm install
npm start
```

_Note that if you're using Windows, some command line tools may require back slashes (`\`) in your directory paths._

The React app should launch in your browser at http://localhost:3000. When you save changes to a file in the front-end code, the React app will automatically display your changes.

### Running the Automated Tests
From the `integrate-interview-frontend` subdirectory, run the following in a command line:
```
npm test
```