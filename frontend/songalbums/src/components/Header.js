import React, { Component } from 'react'
import PropTypes from 'prop-types';

class Header extends Component {


/*  static defaultProps = {
    title:"Varsayılan Başlık",
    slogan:"Kayıtedilen Başlık"
  }*/


    render() {

        return (
            <section className="py-5 text-center container">
            <div className="row py-lg-5">
              <div className="col-lg-6 col-md-8 mx-auto">
                <h1 className="fw-light">{this.props.title}</h1>
                <p className="lead text-muted">{this.props.slogan}</p>
                  <a href="#" className="btn btn-secondary my-2">Rock</a>
                  <a href="#" className="btn btn-secondary my-2">Hip Hop </a>
                  <a href="#" className="btn btn-secondary my-2">Dans ve Elektronik</a>
                  <a href="#" className="btn btn-secondary my-2">Pop</a>
                  <a href="#" className="btn btn-secondary my-2">Caz</a>
              </div>
            </div>
          </section>
        )
    }
}
Header.defaultProps= {
    title:"Varsayılan Başlıkkkkkk",
    slogan:"Kayıtedilen Başlıkkkk"
  }
 
 
Header.propTypes = {
    title: PropTypes.string,
    slogan: PropTypes.string
  };




  export default Header
