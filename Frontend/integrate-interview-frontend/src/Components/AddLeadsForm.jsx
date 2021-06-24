import React, {useState} from 'react'

export default function AddLeadsForm({handleAddLead}) {
  const [leadInputs, setLeadInputs] = useState({})

  const handleOnInput = (e: any) => {
    const element = e.target
    setLeadInputs({...leadInputs, [e.target.name]: element.value})
  }

  return (
    <form className='add-lead-form'>
      <div>
        <label htmlFor="title">Title</label>
        <input onChange={handleOnInput} id='title' name='title'></input>
      </div>
      <div>
        <label htmlFor="name">First Name</label>
        <input onChange={handleOnInput} id='name' name='firstName'></input>
      </div>
      <div>
        <label htmlFor="lastname">Last Name</label>
        <input onChange={handleOnInput} id='lastname' name='lastName'></input>
      </div>
      <div>
        <label htmlFor="streetaddress">Street Address</label>
        <input onChange={handleOnInput} id='streetaddress' name='streetAddress'></input>
      </div>
      <div>
        <label htmlFor="city">City</label>
        <input onChange={handleOnInput} id='name' name='city'></input>
      </div>
      <button type='submit' onClick={(e)=>handleAddLead(e, leadInputs)}>Add Lead</button>
    </form>
  )
}