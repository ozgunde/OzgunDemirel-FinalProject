import React, { Component } from 'react'

class Search extends Component {
    render() {
        return (
        <form className="row g-3 nb-5">
            <div className="col-8">
                <input type="text" className="form-control" placeholder="Şarkılar.." />
            </div>
            <div className="col-4">
               <input 
                type="submit" 
                className="form-control btn-block btn btn-danger text-white" 
                />
            </div>
        </form>
        );
    }
}

export default Search
