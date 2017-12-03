# Jingzi

My pet project Web Service that returns a customizable response:
* Response StatusCode
* Response body (Json)
* Delay of the response (ms)

# Usage

### Example request

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