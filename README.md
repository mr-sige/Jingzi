# Jingzi

Jingzi (镜子 - Chineese for mirror) is Web Service with a single endpoint. When called it can return a custom `HTTP Status Code` and `Response Body` with a `delay`.

# Build

1. Open Jingzi.sln
1. Restore NuGet packages
1. Run

# Usage

Endpoint URL: `http://localhost:49920/api/Jingzi`

#### Http POST:

````json
{
  "ResponseBody": {
    "response item 1": "value 1",
    "response item 2": "value 2"
  },
  "ResponseLatency": 1000,
  "ResponseStatusCode": 201
}
````
#### Response:
`Response time: 1034ms`

`Status Code: 201`

Body:
````json
{
    "response item 1": "value 1",
    "response item 2": "value 2"
}
````