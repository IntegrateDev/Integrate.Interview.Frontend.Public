import {useEffect, useState} from 'react'
import client from '../services/api-client'


export default function useGetLeads() {
  const [leads, setLeads] = useState([])
  const [status, setStatus] = useState('')
  const [updateLeads, setUpdateLeads] = useState(true)


  useEffect(() => {
    const getLeads = () => {
      setStatus('loading')
      client('/person', {headers: {"accept": "application/json"}}).then(data => {
        setStatus('success')
        setLeads(data)
        setUpdateLeads(false)
      }, error => {
        setStatus('error')
        alert(`There was an error loading the leads. ${error}`)
      })
    }
    if (updateLeads) {
      getLeads()
    }
  }, [updateLeads])
  return {leads, status, setUpdateLeads}
}