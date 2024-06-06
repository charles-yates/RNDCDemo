import { useEffect, useState } from 'react';
import { Api } from "./api";
import './App.css';

function App() {
    const [products, setProducts] = useState();

    useEffect(() => {
        Api.get('/Product').then(data => {
            setProducts(data);
        }).catch(error => {
            console.log(error);
        });
    }, []);

    const contents = products === undefined
        ? <p><em>Loading... Please refresh once the ASP.NET backend has started. See <a href="https://aka.ms/jspsintegrationreact">https://aka.ms/jspsintegrationreact</a> for more details.</em></p>
        : <table className="table table-striped" aria-labelledby="tableLabel">
            <thead>
                <tr>
                    <th>Label</th>
                    <th>Description</th>
                    <th>ABV</th>
                    <th>Proof</th>
                    <th>Liters</th>
                    <th>Class</th>
                </tr>
            </thead>
            <tbody key="0">
                {products.length ?
                    products.map((product, key) =>
                        <tr key={key}>
                            <td>{product.label}</td>
                            <td>{product.ExRefProduct.ExDscrptnFull}</td>
                            <td>{product.ExRefProduct.ExABV}</td>
                            <td>{product.ExRefProduct.ExProof}</td>
                            <td>{product.ExRefProduct.ExUnitOfMeasure.ExLiters}</td>
                            <td>{product.ExRefProduct.ExCrpClass.ExCorporateClassDesc}</td>
                        </tr>
                    )
                    : <tr><td colSpan="6">No products...</td></tr>}
            </tbody>
        </table>;

    return (
        <div>
            <h1 id="tableLabel">Product Data</h1>
            {contents}
        </div>
    );
}

export default App;