import React, { useEffect, createContext, useState, useContext } from 'react'

export const ProductContext = createContext()

function ProductProvider({ children }) {
    const [albumData, setAlbumData] = useState([])
    const [pageNumber, setPageNumber] = useState(0);
    const records = 9
    const totalPageNumber = 6
    
    useEffect(() => {
        fetch(`https://jsonplaceholder.typicode.com/albums/1/photos?_start=${pageNumber * records}&_limit=${records}`)
            .then(response => response.json())
            .then(data => setAlbumData(data))

    }, [])
    const handlePage = async (pageNumber) => {
        
        console.log("handle page function has: ", pageNumber);
        await fetch(`https://jsonplaceholder.typicode.com/albums/1/photos?_start=${pageNumber * records}&_limit=${records}`)
                .then(response => response.json())
                .then(data => setAlbumData(data))
    }
    return (

    <ProductContext.Provider value = {{ pageNumber, 
                                        albumData, 
                                        records, 
                                        totalPageNumber, 
                                        setPageNumber, 
                                        handlePage }}> {children} </ProductContext.Provider>)
}

export const useProductContext = () => useContext(ProductContext)

export default ProductProvider
