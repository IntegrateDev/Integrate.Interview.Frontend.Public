import React from 'react'
import useGetLeads from '../Hooks/useGetLeads'
import AddLeadsForm from './AddLeadsForm'
import client from '../services/api-client'
import {useTable} from 'react-table'
import './marketing-leads.css'

export default function MarketingLeads() {
  const {leads, status, setUpdateLeads} = useGetLeads()

  const columns = React.useMemo(
    () => [
      {
        Header: 'Title',
        accessor: 'title',
      },
      {
        Header: 'First Name',
        accessor: 'firstName',
      },
      {
        Header: 'Last Name',
        accessor: 'lastName',
      },
    ],
    []
  )

  const handleAddLead = (e: any, leadInputs) => {
    e.preventDefault()
    client('/person', {body:leadInputs}).then(resp => {
      alert('Lead successfully added!')
      setUpdateLeads(true)
    }, error => {
      alert(error)
    })
  }
 
  const {
    getTableProps,
    getTableBodyProps,
    headerGroups,
    rows,
    prepareRow,
  } = useTable({ columns, data: leads })

  if (status === 'loading') {
    return <div className='loading'>...loading</div>
  }
  return (
    <div className='marketing-leads'>
      <AddLeadsForm handleAddLead={handleAddLead}/>
      <table {...getTableProps()} className='view-leads-table'>
        <thead>
          {headerGroups.map(headerGroup => (
            <tr {...headerGroup.getHeaderGroupProps()} className='leads-col-headers'>
              {headerGroup.headers.map(column => (
                <th
                  {...column.getHeaderProps()}
                >
                  {column.render('Header')}
                </th>
              ))}
            </tr>
          ))}
        </thead>
        <tbody {...getTableBodyProps()}>
          {rows.map(row => {
            prepareRow(row)
            return (
              <tr {...row.getRowProps()}>
                {row.cells.map(cell => {
                  return (
                    <td
                      {...cell.getCellProps()}
                      className='leads-cell'
                    >
                      {cell.render('Cell')}
                    </td>
                  )
                })}
              </tr>
            )
          })}
        </tbody>
      </table>
    </div>
  )
}