# API Documentation: ParksLookupAPI 

### By: Elle Hailu

**Description:** Welcome to the ParksLookupAPI. This API provides endpoints to manage parks within the parks database. You can access, create, update, and delete messages. 

**Supported binding**

- C#
`"https://localhost:5000/api/Parks/"`
- JavaScript
`"https://localhost:5000/api/Parks/"`

#### Endpoints

1. **GET: api/Parks**
    - **Description:** Reterieves a list of parks based on specified filters.
    - **Query Parameters:**
        - `name` (optional): Filters parks by the given name.
        `"https://localhost:5000/api/Parks?name=[park name]"`
        - `state` (optional): Filters parks by the state they are located in.
        `"https://localhost:5000/api/Parks?state=[state name]"`
        - `yearOfEstablishment` (optional): Filters parks by the year they were established.
    - **Response:**
        - Status Code: `200 OK`
        - Content: A JSON array containing park objects with name, state, type of designation, and year of establishment.
 


### Known Bugs 
- The user can't search for a two letter state name by typing in the full state name. 