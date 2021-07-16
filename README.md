# Integrate Front-End Interview Exercise
## Overview
The center of Integrate's product is the __Demand Acceleration Platform (DAP)__. DAP allows users to interact with marketing lead data. A __marketing lead__ is a person who shows interest in a company’s products or services. Our customers need marketing leads that are correct and likely to generate business.

We are striving to build a world-class UI using React. The UI interacts with microservices that expose their functionality through RESTful APIs. 

For this exercise, you will create a simple app using React. This repo provides a working `create-react-app` project for you to use as a base.

The app should allow users to:
* View all marketing leads (i.e., people)
* Add a person to the list

Backend API endpoints are provided in this repo, along with Swagger documentation describing them. The goal is working software that can be demonstrated in a browser.

You can use any additional libraries you would like (e.g., React-Bootstrap, Material-UI, etc.), but make sure to keep your design simple. We don't expect you to complete an enterprise-level app during a brief interview!

## Prerequisites
You must have the following dependencies installed:
* [.NET Core](https://dotnet.microsoft.com/download)
* [NodeJS](https://nodejs.org/en/)

## Backend API
### Running the API
From the root directory of this repo, run the following in a console.

```
cd ./Backend/Integrate.Interview.Frontend/Integrate.Interview.Frontend/
dotnet run
```

_Note that if you're using Windows, some command line tools may require back slashes (`\`) in your directory paths._

### Viewing the API Documentation
The API includes Swagger documentation so you can easily call it from your UI. With the API running, navigate to `https://localhost:5001/swagger`.

## React UI
### Running the React App
From the root directory of this repo, run the following in a console:

```
cd ./Frontend/integrate-interview-frontend
npm install
npm start
```

_Note that if you're using Windows, some command line tools may require back slashes (`\`) in your directory paths._

The React app should launch in your browser at http://localhost:3000. When you save changes to a file in the front-end code, the React app will automatically display your changes.

### Running the Automated Tests
From the `integrate-interview-frontend` subdirectory, run the following in a console:
```
npm test
```
