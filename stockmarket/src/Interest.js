import React from 'react';
import Plot from 'react-plotly.js';

class Interest extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            stockChartXValues: [],
            stockChartYValues: []
        }
    }

    componentDidMount() {
        this.fetchStock();
    }
    
    fetchStock() {
        const pointerToThis = this;
        // const API_KEY = 'OEKHOQR51XS2XJ4P';
        const API_KEY = 'RJZOYVBITE70DG20';
        // const API_KEY = '41B7ZM7IAC7DJBLI';
        let API_Call = `https://www.alphavantage.co/query?function=FEDERAL_FUNDS_RATE&interval=monthly&apikey=${API_KEY}`;
        let stockChartXValuesFunction = [];
        let stockChartYValuesFunction = [];


        fetch(API_Call)
            .then(
                function(response) {
                    return response.json();
                }
            )
            .then(
                function(data) {
                    // console.log(data['data']);

                    for (var key in data['data']) {
                        stockChartXValuesFunction.push(data['data'][key]['date']);
                        stockChartYValuesFunction.push(data['data'][key]['value']);
                    }

                    pointerToThis.setState({
                        stockChartXValues: stockChartXValuesFunction,
                        stockChartYValues: stockChartYValuesFunction
                    })
                }
            )
    }

    render() {
        return (
            <div>
                <Plot
                    data={[
                    {
                        x: this.state.stockChartXValues,
                        y: this.state.stockChartYValues,
                        type: 'scatter',
                        mode: 'lines+markers',
                        marker: {color: 'red'},
                    },
                    ]}
                    layout={{width: 720, height: 440, title: 'Interest Rate'}}
                />
            </div>
        )
    }
}

export default Interest;