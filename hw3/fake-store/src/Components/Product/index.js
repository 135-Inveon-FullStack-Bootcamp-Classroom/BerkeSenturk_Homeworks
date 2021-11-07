import React,{ useContext } from 'react'
import Card from '@mui/material/Card';
import CardActions from '@mui/material/CardActions';
import CardContent from '@mui/material/CardContent';
import CardMedia from '@mui/material/CardMedia';
import Button from '@mui/material/Button';
import Typography from '@mui/material/Typography';
import Grid from '@mui/material/Grid';
import Pagination from '@mui/material/Pagination';
import Stack from '@mui/material/Stack';
import { CardActionArea } from '@mui/material';
import Box from '@mui/material/Box';
import { ProductContext } from '../../Context/ProductContext';

const Product = () => {

    const { albumData, pageNumber, totalPageNumber, handlePage, setPageNumber } = useContext(ProductContext)

    const handleChange = (event, value) => {
        setPageNumber(value)
        handlePage(value-1)
        console.log(pageNumber);
    }

    return (
        <div>
            <Box style= {{ display:"flex", justifyContent:'center'}}>
                <img src="https://picsum.photos/id/1059/1900/600" alt="" />
            </Box>

            <Grid style={{marginTop:"10px"}} container spacing={{ xs: 2, md: 2, lg: 2 }} columns={{ xs: 4, sm: 8, md: 12 }}>
            
            {
                albumData.map( (data,index) => 
                    <Grid   container
                            direction="row"
                            justifyContent="center"
                            alignItems="center" item xs={2} sm={4} md={4} key={index}>
                        
                        <Card sx={{ maxWidth: 200 }}>
                            <CardActionArea>
                                <CardMedia
                                    component="img"
                                    height="140"
                                    image={data.thumbnailUrl}
                                    alt="green iguana"
                                />
                                <CardContent>
                                    <Typography gutterBottom variant="h5" component="div">
                                        {data.id}
                                    </Typography>
                                    <Typography variant="body2" color="text.secondary">
                                        {data.title}
                                    </Typography>
                                </CardContent>
                                <CardActions>
                                    <Button size="small">Buy Now!</Button>
                                </CardActions>
                            </CardActionArea>
                        </Card>
                    </Grid>)
            }
            </Grid>
            <Stack style={{marginTop:"40px", textAlign:'center'}} spacing={2}>
                <Typography>Page: {pageNumber}</Typography>
                <Pagination style={{display:'flex',justifyContent:'center'}} count= {totalPageNumber} 
                            onChange={handleChange} 
                            size="large" 
                            color="primary" />
            </Stack>
        </div>
    )
}

export default Product
