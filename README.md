# API Documentation: ParksLookupAPI

#### By: Elle Hailu

**Description:** Welcome to the ParksLookupAPI. This API provides endpoints to manage parks within the parks database. You can access, create, update, and delete messages.

## Technologies Used

- C#
- .NET

## Setup/Installation Requirements

- Clone this repository to your desktop
- Open your terminall and navigate to the top level of the directory
  Navigate to the production directory in your terminal.
- Create a new file in your production folder and name it "appsettings.json".
- Update the contents of your appsettings.json file with the following.

```
{
  "ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Port=3306;database=[DATABASE-NAME];uid=[YOUR-USER-NAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
    }
  }
```

- Replace the place holder user name and password in the appsettings.json file with your actual username and password.
- Confirm you have `mySql WorkBench` installed, if you don't follow the installation instructions found here. Then in your terminal run the following command: `dotnet ef database update`

- Once your local database is updated, launch postman. If you don't have postman installed, follow installation instructions found here.

**Supported binding**

- C#
  `"https://localhost:5001/api/Parks/"`
- JavaScript
  `"https://localhost:5001/api/Parks/"`

#### Endpoints

1. **GET: api/Parks**

   - **Description:** Reterieves a list of parks based on specified filters.
   - **Query Parameters:**

     - `name` (optional): Filters parks by the given name.
       `"https://localhost:5001/api/Parks?name=[park name]"`
     - `state` (optional): Filters parks by the state they are located in.
       `"https://localhost:5001/api/Parks?state=[state name]"`
     - `yearOfEstablishment` (optional): Filters parks by the year they were established.
     - **Multiple Parameters:**
       _You can search for a park by using multiple query parameters. You can use all or any combination of the three query parameters._
       - `name`, `state`
         `"https;//localhost:5001/api/Parks?name=[park name]&state=[state name]"`

   - **Response:**

     - Status Code: `200 OK`
     - Content: A JSON array containing park objects with name, state, type of designation, and year of establishment.

   -

2. **GET: api/Parks/{id}**

   - **Description:** Retrieves a specific park by its Id.
   - **Path Parameters:**
     - `id` (int): Id of the park to retrieve.
   - **Example:**
     - `"https://localhost:5001/api/Parks/{id}"`
   - **Returns:**
     - 200 OK with `Park` object: If the park is found.
     - 404 Not Found: If the park with the given Id does not exist.

3. **Put: api/Parks/{id}**

- **Description:** Update an existing park.
  - _User can update one or multiple properties of the selected park_
- **Path Parameters:**
  - `id` (int): Id of the park to update.
- **Request Body** `Park` object with updated fields.
- **Returns:**
  - 204 No Content: If the update is successful.
  - 400 Bad Request: If the provided Id does not match the park Id.
  - 404 Not Found: If the park with the given Id does not exist.
- **Example:**
  - `"https://localhost:5001/api/Parks/{id}"`
  - `{
    Name = "[updated park name]"
    State = "[updated state name]"
    Designation = "[updated park designation]"
    YearOfEstablishment = "[updated year of estabishment]"
}`

4. **Post: api/Parks**

- **Description:** Create a new park.
- **Request Body:** `Park` object with required fields.
- **Returns:**
  - 201 Created: If the park is successfully created. It returns the created park in the response body.
  - 400 Bad Request: If the provided park object is invalid.
- **Example:**
  - `"https://localhost:5001/api/Parks/"`
  - `{
    Name = "[new park name]"
    State = "[new park state name]"
    Designation = "[new park designation]"
    YearOfEstablishment = "[new park year of estabishment]"
}`

5. **Delete: api/Parks/{id}**

- **Description:** Delete a park by its Id.
- **Path Parameters:**
  - `id` (int): Id of the park to delete.
- **Returns:**
  - 204 No Content: If the park is successfully deleted.
  - 404 Not Found: If the park with the given Id does not exist.

### Known Bugs

- The user can generate an authentication token, however currently the user can't get authenticated when using the authentication token that is generated. The user stilll gets a `401 unauthorized` error.
- If you identify other bugs please reach out to Elle Hailu (hailu.elle@gmail.com).

## License

MIT [![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

Copyright (c) _2023_ _Elle Hailu_

_Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:_

_The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software._

_THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE._
