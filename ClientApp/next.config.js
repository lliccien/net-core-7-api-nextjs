/** @type {import('next').NextConfig} */

const rewrites = () => {
    return [
      {
        source: "/swagger",
        destination: "https://localhost:5001/swagger",
      },
    ];
  };


const nextConfig = {
    images: {
        loader: 'akamai',
        path: '/'
    },
    rewrites,
    
}

module.exports = nextConfig
