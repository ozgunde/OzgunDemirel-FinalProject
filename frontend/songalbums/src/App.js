import React, { Component } from 'react'
import Navbar from './components/Navbar'
import Header from './components/Header'
import Search from './components/Search'
import CardList from './components/CardList'
import Footer from './components/Footer'

class App extends Component {
  render() {
    return (
      <>
          <Navbar />
          <main>
            <Header title="MogMusic dinle, ruhunu dizginle" slogan="İyi günde, kötü günde her halinle sen de bizimle dinle."/>
            <div className="MogMusic" py-5 bg="light">
              <div className="container">
              <Search />
              <CardList />
              </div>
          </div>
      
        </main>
      
        <Footer/>
      </>
    )
  }
}

export default App
