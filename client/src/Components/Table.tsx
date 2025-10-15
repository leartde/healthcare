import React from 'react';

type TableProps = {
  headers : string[];
  rows: React.ReactNode[][];
}
const Table = ({headers, rows}: TableProps) => {
  return (
    <table className="min-w-full bg-white rounded-lg overflow-hidden">
      <thead className="bg-green-700 text-white">
      <tr>
{headers.map((header) => (
          <th key={header} className="py-3 px-4 text-left font-semibold">{header}</th>
        ))}
      </tr>
      </thead>
      <tbody>
      {rows.length > 0 ? (
        rows.map((row, index) => (
          <tr
            key={index}
            className={index % 2 === 0 ? 'bg-green-50 hover:bg-green-100' : 'bg-white hover:bg-green-100'}
          >

              {row.map((cell, cellIndex) => (
                <td className="py-3 px-4 border-b border-green-200" key={cellIndex}>
                  {cell}
                </td>
                ))}

          </tr>
        ))
      ) : (
        <tr>
          <td colSpan="7" className="py-4 px-4 text-center text-gray-500">
            No records found.
          </td>
        </tr>
      )}
      </tbody>
    </table>
  );
};

export default Table;
