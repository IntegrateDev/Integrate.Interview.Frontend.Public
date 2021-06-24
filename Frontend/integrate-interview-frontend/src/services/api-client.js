export default function client (
  endpoint,
  {body, ...customConfig} = {}
) {
  const url = 'https://localhost:5001'
  const headers = {"Content-Type": 'application/json'}
  const config = {
    method: body ? 'POST' : 'GET',
    ...customConfig,
    headers: {
      ...headers,
      ...customConfig.headers
    }
  }

  if (body) {
    config.body = JSON.stringify(body)
  }

  return fetch(`${url}${endpoint}`, config).then(async response => {
    const text = await response.text()
    try {
      const data = await JSON.parse(text)
      if (response.ok) {
        return data
      } else {
        return Promise.reject(data)
      }
    } catch (parsingError) {
      if (!response.ok) {
        return text
      } else {
        return Promise.reject(text)
      }
    }
  })
}